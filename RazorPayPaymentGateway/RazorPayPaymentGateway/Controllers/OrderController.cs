using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Razorpay.Api;
using RazorPayPaymentGateway.Data.Repository.IRepository;
using RazorPayPaymentGateway.Models;

namespace RazorPayPaymentGateway.Controllers
{
    public class OrderController : Controller
    {


        [BindProperty]
      public OrderEntity _orderDetails { get; set; }

        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult InitiateOrder()
        {
            string key = "rzp_test_v4SDEodoPxTnn0";
            string secret = "6bnIWOfHHsjyWJtaZDgSjkAL";

            Random random = new Random();
            string TransactionId=random.Next(0,10000).ToString();

            
            Dictionary<string, object> input = new Dictionary<string, object>();
            input.Add("amount",Convert.ToDecimal(_orderDetails.TotalAmount)* 100); // this amount should be same as transaction amount
            input.Add("currency", "INR");
            input.Add("receipt", TransactionId);


            RazorpayClient client = new RazorpayClient(key, secret);
            Razorpay.Api.Order order = client.Order.Create(input);
            ViewBag.orderId = order["id"].ToString();
            return View("Payment",_orderDetails);
        }
        public IActionResult Payment( string razorpay_payment_id,string razorpay_order_id,string razorpay_signature)
        {
            Dictionary<string, string> attributes = new Dictionary<string, string>();
            attributes.Add("razorpay_payment_id", razorpay_payment_id);
            attributes.Add("razorpay_order_id", razorpay_order_id);
            attributes.Add("razorpay_signature", razorpay_signature);

            Utils.verifyPaymentSignature(attributes);

            OrderEntity orderEntity = new OrderEntity();
            orderEntity.TransactionId=razorpay_payment_id;
            orderEntity.OrderId= razorpay_order_id;

            return View("PaymentSucces",orderEntity);
        }
    }
}
