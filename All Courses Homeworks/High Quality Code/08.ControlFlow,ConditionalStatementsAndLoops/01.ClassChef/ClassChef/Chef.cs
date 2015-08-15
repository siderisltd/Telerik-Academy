namespace ControlFlow
{
    using System;

    public class Chef
    {
        private IVegetable firstVegetable;
        private IVegetable secondVegetable;
        private IBowl bowl;

        public Chef(IVegetable firstVegetable, IVegetable secondVegetable, IBowl bowl)
        {
            this.firstVegetable = firstVegetable;
            this.secondVegetable = secondVegetable;
            this.bowl = bowl;
        }

        public void Cook()
        {
            var firstVegetable = this.GetVegetable(this.firstVegetable);
            var secondVegetable = this.GetVegetable(this.secondVegetable);
            this.Peel(secondVegetable);
            this.Peel(firstVegetable);
            this.bowl = this.GetBowl();
            this.Cut(secondVegetable);
            this.Cut(firstVegetable);
            this.bowl.Add(firstVegetable);
            this.bowl.Add(secondVegetable);
        }

        private void Cut(IVegetable vegetable)
        {
            throw new NotImplementedException();
        }

        private void Peel(IVegetable carrot)
        {
            throw new NotImplementedException();
        }

        private IVegetable GetVegetable(IVegetable vegetable)
        {
            return vegetable;
        }

        private Bowl GetBowl()
        {
            throw new NotImplementedException();
        }
    }
}
