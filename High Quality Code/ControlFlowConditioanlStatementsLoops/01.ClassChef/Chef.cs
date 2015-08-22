namespace Cooking
{
    using System;

    public class Chef
    {

        public void Cook()
        {
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();

            this.Peel(potato);
            this.Peel(carrot);

            this.Cut(potato);
            this.Cut(carrot);

            Bowl bowl = this.GetBowl();
            bowl.Add(potato);
            bowl.Add(carrot);
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private Bowl GetBowl()
        {   
            return new Bowl();
        }

        private void Cut(Vegetable someVegetable)
        {
            //...
        }

        private void Peel(Vegetable someVegetable)
        {
            //...
        }
    }
}