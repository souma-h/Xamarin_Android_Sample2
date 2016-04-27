using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Tokudane
{
    [Activity(Label = "Tokudane", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += button_Click;

        }

        private void button_Click(object sender, EventArgs e)
        {
            double i_price_1 = 0;
            double i_unitprice_1;
            double.TryParse(FindViewById<EditText>(Resource.Id.e_price_1).Text, out i_price_1);
            double i_quantity_1 = 0;
            double.TryParse(FindViewById<EditText>(Resource.Id.e_quantity_1).Text, out i_quantity_1);

            if (i_price_1.Equals(0) || i_quantity_1.Equals(0))
            {
                i_unitprice_1 = 0;
            }
            else
            {
                i_unitprice_1 = (i_price_1 / i_quantity_1);
                i_unitprice_1 = Math.Round(i_unitprice_1,2);
            }
            if (i_unitprice_1 <= 0)
            {
                i_unitprice_1 = double.MaxValue;
            }

            double i_price_2 = 0;
            double i_unitprice_2;
            double.TryParse(FindViewById<EditText>(Resource.Id.e_price_2).Text, out i_price_2);
            double i_quantity_2 = 0;
            double.TryParse(FindViewById<EditText>(Resource.Id.e_quantity_2).Text, out i_quantity_2);

            if (i_price_2.Equals(0) || i_quantity_2.Equals(0))
            {
                i_unitprice_2 = 0;
            }
            else
            {
                i_unitprice_2 = (i_price_2 / i_quantity_2);
                i_unitprice_2 = Math.Round(i_unitprice_2,2);
            }
            if (i_unitprice_2 <= 0)
            {
                i_unitprice_2 = double.MaxValue;
            }


            double i_price_3 = 0;
            double i_unitprice_3;
            double.TryParse(FindViewById<EditText>(Resource.Id.e_price_3).Text, out i_price_3);
            double i_quantity_3 = 0;
            double.TryParse(FindViewById<EditText>(Resource.Id.e_quantity_3).Text, out i_quantity_3);
            if (i_price_3.Equals(0) || i_quantity_3.Equals(0))
            {
                i_unitprice_3 = 0;
            }
            else
            {
                i_unitprice_3 = (i_price_3 / i_quantity_3);
                i_unitprice_3 = Math.Round(i_unitprice_3,2);
            }
            if (i_unitprice_3 <= 0)
            {
                i_unitprice_3 = double.MaxValue;
            }


            double[] nums = { i_unitprice_1, i_unitprice_2, i_unitprice_3 };

            var min = double.MaxValue;
            var max = double.MinValue;
            foreach (var n in nums)
            {
                if (min > n)
                    min = n;
                if (max < n)
                    max = n;
            }
            if (!i_unitprice_1.Equals(double.MaxValue))
            {
                FindViewById<EditText>(Resource.Id.e_unitprice_1).Text = i_unitprice_1.ToString();
            }
            if (!i_unitprice_2.Equals(double.MaxValue))
            {
                FindViewById<EditText>(Resource.Id.e_unitprice_2).Text = i_unitprice_2.ToString();
            }
            if (!i_unitprice_3.Equals(double.MaxValue))
            {
                FindViewById<EditText>(Resource.Id.e_unitprice_3).Text = i_unitprice_3.ToString();
            }


            if (min.Equals(i_unitprice_1))
            {
                FindViewById<TextView>(Resource.Id.t_lowplece_1).Text = "最安！";
            }
            if (min.Equals(i_unitprice_2))
            {
                FindViewById<TextView>(Resource.Id.t_lowplece_2).Text = "最安！";
            }
            if (min.Equals(i_unitprice_3))
            {
                FindViewById<TextView>(Resource.Id.t_lowplece_3).Text = "最安！";
            }

        }
    }
}

