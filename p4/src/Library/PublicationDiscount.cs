using System;

namespace Ucu.Poo.Defense
{
    public class PublicationDiscount: IPublicationItem
    {
        private int amount;

        public int SubTotal
        {            
            get
            {
                return this.amount;
            }
            set
            {
                if (value > 0)
                {
                    throw new ArgumentException("El importe debe ser negativo");
                }
                this.amount = value;
            }
        }

        public PublicationDiscount(int amount)
        {
            if (this.amount > 0)
            {
                throw new ArgumentException("El importe debe ser negativo");
            }
            this.SubTotal = amount;
        }
    }
}