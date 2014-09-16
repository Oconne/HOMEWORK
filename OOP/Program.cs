using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop mpc = new Laptop();
            

        }
    }

    class Laptop { 
    
      private    string   model_;
      private    string   manufacturer_;
      private    string   processor_;
      private    string   graphics_card_;
      private   Battery   battery_;


      public Laptop() { }

      public Laptop(string model,string manufacturer,string processor,string graphicCards, string batteryModel,double batteryLife) {

          this.Model = model;
          this.Manufacturer = manufacturer;
          this.Processor = processor;
          this.GraphicCard = graphicCards;
          this.BatteryModel = batteryModel;
          this.BatteryLife = batteryLife;


      }



      public string BatteryModel {

          get { return this.battery_.BatteryModel; }
          set { this.battery_.BatteryModel = value; }
      
      
      
      }


      public double BatteryLife {

          get { return this.battery_.BatteryLife; }
          set { this.battery_.BatteryLife = value; }
      
      
      
      }


      public string Model
      {
          get { return this.model_; }
          set {
              if (String.IsNullOrEmpty(value))
              {
                  throw new ArgumentException("Invalid model!");
              }
              this.Model = value;

          }
      }

         public string Manufacturer
              {
                  get { return this.manufacturer_; }
                  set {
                      if (String.IsNullOrEmpty(value))
                      {
                          throw new ArgumentException("Invalid manufacturer!");
                      }
                      this.manufacturer_ = value;

                  }
              }


         public string Processor
                      {
                          get { return this.processor_; }
                          set {
                              if (String.IsNullOrEmpty(value))
                              {
                                  throw new ArgumentException("Invalid processor!");
                              }
                              this.processor_ = value;

                          }
                      }

         public string GraphicCard
                              {
                                  get { return this.graphics_card_; }
                                  set {
                                      if (String.IsNullOrEmpty(value))
                                      {
                                          throw new ArgumentException("Invalid Graphic Card!");
                                      }
                                      this.graphics_card_ = value;

                                  }
                              }

        public Battery Battery
                              {
                                  get { return this.battery_; }
                                  set {
                                      if (value==null)
                                      {
                                          throw new ArgumentException("Invalid baterry!");
                                      }
                                      this.battery_ = value;

                                  }
                              }




      override public string ToString() {
      
      string info=String.Format("Model: {0}\nManufacturer: {1}\nProcessor: {3}\nGraphics Card: {4}\nBattery Model: {5}\nBattery life: {6}",
      this.Model, this.Manufacturer, this.Processor,this.GraphicCard,this.battery_.BatteryModel,this.battery_.BatteryLife );
         
      
          return info;
      }




    
    }

    class Battery { 
    
      private    string   battery_;
      private    double   battery_life_=0 ;


      public Battery() { }

      public Battery(string baterryModel, double batteryLife) {

          this.BatteryModel = baterryModel;
          this.BatteryLife = batteryLife;
      }

      public string BatteryModel
      {
          get { return this.battery_; }
          set
          {
              if (String.IsNullOrEmpty(value))
              {
                  throw new ArgumentException("Invalid BatteryModel!");
              }
              this.BatteryModel = value;

          }
      }

     public double BatteryLife
          {
              get { return this.battery_life_; }
              set
              {
                  if (value<0)
                  {
                      throw new ArgumentException("Invalid BatteryLife value!");
                  }
                  this.battery_life_ = value;

              }
          }



    }

}
