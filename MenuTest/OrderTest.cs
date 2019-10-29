using Xunit;
using DinoDiner.Menu;
/* Author: Ethan Nguyen
 * Class: OrderTest.cs
 */
namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void SubtotalShouldNotBeNegative()
        {
            Order order = new Order();
            Fryceritops ft = new Fryceritops();
            ft.Price = -100;
            order.Add(ft);
            Assert.Equal(0, order.SubtotalCost);
            VelociWrap vw = new VelociWrap();
            order.Add(vw);
            Assert.Equal(0, order.SubtotalCost);
        }

        [Fact]
        public void CorrectSubtotalCost()
        {
            Order order = new Order();
            SteakosaurusBurger sb = new SteakosaurusBurger();
            TRexKingBurger tb = new TRexKingBurger();
            Water wat = new Water();
            Tyrannotea tea = new Tyrannotea();
            order.Add(sb);
            order.Add(tb);
            order.Add(wat);
            order.Add(tea);
            Assert.Equal(sb.Price + tb.Price + wat.Price + tea.Price, order.SubtotalCost);

        }

        [Fact]
        public void CorrectSalesTaxCost()
        {
            Order order = new Order();
            DinoNuggets dn = new DinoNuggets();
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            JurassicJava java = new JurassicJava();
            Sodasaurus soda = new Sodasaurus();
            order.Add(dn);
            order.Add(pbj);
            order.Add(java);
            order.Add(soda);

            double sub = dn.Price + pbj.Price + java.Price + soda.Price;
            Assert.Equal(sub * .10, order.SalesTaxCost);
        }

        [Fact]
        public void CorrectTotalCost()
        {
            Order order = new Order();
            VelociWrap vw = new VelociWrap();
            Brontowurst bw = new Brontowurst();
            Triceritots tt = new Triceritots();
            order.Add(vw);
            order.Add(bw);
            order.Add(tt);
            double sub = vw.Price + bw.Price + tt.Price;
            Assert.Equal(sub + sub * .10, order.TotalCost);
        }
    }
}
