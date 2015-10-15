using System;
using Shouldly;

namespace ShoppingCartKata
{
    public class ShoppingCartTests
    {
        readonly ShoppingCart shoppingCart = new ShoppingCart();

        public void SingleACosts50()
        {
            shoppingCart.Scan("A");

            shoppingCart.Total().ShouldBe(50);
        }

        public void TwoACosts100()
        {
            shoppingCart.Scan("A");
            shoppingCart.Scan("A");

            shoppingCart.Total().ShouldBe(100);
        }

        public void ThreeACosts130()
        {
            shoppingCart.Scan("A");
            shoppingCart.Scan("A");
            shoppingCart.Scan("A");

            shoppingCart.Total().ShouldBe(130);
        }

        public void FourACosts180()
        {
            shoppingCart.Scan("A");
            shoppingCart.Scan("A");
            shoppingCart.Scan("A");
            shoppingCart.Scan("A");

            shoppingCart.Total().ShouldBe(180);
        }

        public void SingleBCosts30()
        {
            shoppingCart.Scan("B");

            shoppingCart.Total().ShouldBe(30);
        }

        public void TwoBCosts45()
        {
            shoppingCart.Scan("B");
            shoppingCart.Scan("B");

            shoppingCart.Total().ShouldBe(45);
        }

        public void ThreeBCosts75()
        {
            shoppingCart.Scan("B");
            shoppingCart.Scan("B");
            shoppingCart.Scan("B");

            shoppingCart.Total().ShouldBe(75);
        }

        public void FiveCCosts300()
        {
            shoppingCart.Scan("C");
            shoppingCart.Scan("C");
            shoppingCart.Scan("C");
            shoppingCart.Scan("C");
            shoppingCart.Scan("C");

            shoppingCart.Total().ShouldBe(300);
        }

        public void FiveDCosts495()
        {
            shoppingCart.Scan("D");
            shoppingCart.Scan("D");
            shoppingCart.Scan("D");
            shoppingCart.Scan("D");
            shoppingCart.Scan("D");

            shoppingCart.Total().ShouldBe(495);
        }

        public void Combination()
        {
            shoppingCart.Scan("A");
            shoppingCart.Scan("A");
            shoppingCart.Scan("B");
            shoppingCart.Scan("A");
            shoppingCart.Scan("D");
            shoppingCart.Scan("C");
            shoppingCart.Scan("D");
            shoppingCart.Scan("C");
            shoppingCart.Scan("C");
            shoppingCart.Scan("B");
            shoppingCart.Scan("D");
            shoppingCart.Scan("D");
            shoppingCart.Scan("A");
            shoppingCart.Scan("D");
            shoppingCart.Scan("C");
            shoppingCart.Scan("C");

            shoppingCart.Total().ShouldBe(1020);
        }
    }

    public class ShoppingCart
    {
        private int countA;
        private int countB;
        private int countC;
        private int countD;

        public void Scan(string product)
        {
            if (product == "A") countA++;
            if (product == "B") countB++;
            if (product == "C") countC++;
            if (product == "D") countD++;
        }

        public int Total()
        {
            return TotalForA()
                 + TotalForB()
                 + TotalForC()
                 + TotalForD();
        }

        private int TotalForA()
        {
            return 130 * (countA / 3)
                  + 50 * (countA % 3);
        }

        private int TotalForB()
        {
            return 45 * (countB / 2)
                 + 30 * (countB % 2);
        }

        private int TotalForC()
        {
            return 60 * countC;
        }

        private int TotalForD()
        {
            return 99 * countD;
        }
    }
}
