using System;

namespace formsClinicProject
{
    public class Cabinet
    {

        private int number, id_office;
        public Cabinet()
        {
        }

        public Cabinet(int number)
        {
            this.Number = number;
        }

        public Cabinet(int id, int number)
        {
            this.id_office = id;
            this.number = number;

        }

        public int Number 
        { 
            get => number; 
            
            set 
            {
                if (value == 0)
                    throw new ArgumentException("Cabinet number cannot be 0.");

                number = value; 
            } 
        }

        public int Id { get => id_office; set => id_office = value; }
    }
}
