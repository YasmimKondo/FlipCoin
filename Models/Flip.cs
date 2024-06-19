using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin.Models
{
    internal class Flip(Boolean selectedCoin)
    {
        public Boolean selectedCoin { get; set; } = selectedCoin;
        public String result {  get; set; }
        public String imageName { get; set; }

        public void flipCoin()
        {
            Random rand = new Random();
            if (rand.Next(0, 3) == 1)
            {
                this.result = (selectedCoin) ? "Você venceu!" : "Você perdeu!";
                this.imageName = "coroa.jpg";
            }
            else
            {
                this.result = (!selectedCoin) ? "Você venceu!" : "Você perdeu!";
                this.imageName = "cara.jpg";
            }
        }
    }

}
