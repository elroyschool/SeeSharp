using System;
using System.Collections.Generic;
using System.Text;

namespace MP3Constructor
{

    public struct MP3
    {

        public int Id;
        /*public int Stock;*/
        public string Make;
        public string Model;
        public float Mb;
        public double Price;

        public MP3(int p_id, /*int p_stock,*/ string p_make, string p_model, float p_mb, double p_price)
        {
            this.Id = p_id;
            /*this.Stock = p_stock;*/
            this.Make = p_make;
            this.Model = p_model;
            this.Mb = p_mb;
            this.Price = p_price;
        }
    }
}

