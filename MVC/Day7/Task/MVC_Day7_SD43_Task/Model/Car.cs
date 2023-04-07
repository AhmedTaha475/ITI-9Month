namespace MVC_Day7_SD43_Task.Model
{
    public class Car
    {

        public Car(int _num,string _color,string _mod,string _man)
        {
            Num = _num;
            Color = _color;
            Model = _mod;
            Manufacture= _man;
            
        }

        public int Num { get; set; }

        public string Color { get; set; }

        public string Model { get; set; }

        public string Manufacture { get; set; }

      
    }
}
