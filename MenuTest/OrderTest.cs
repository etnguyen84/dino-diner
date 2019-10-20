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
            order.Items.Add(ft);
            Assert.Equal(0, order.SubtotalCost);
            VelociWrap vw = new VelociWrap();
            order.Items.Add(vw);
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
            order.Items.Add(sb);
            order.Items.Add(tb);
            order.Items.Add(wat);
            order.Items.Add(tea);
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
            order.Items.Add(dn);
            order.Items.Add(pbj);
            order.Items.Add(java);
            order.Items.Add(soda);

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
            order.Items.Add(vw);
            order.Items.Add(bw);
            order.Items.Add(tt);
            double sub = vw.Price + bw.Price + tt.Price;
            Assert.Equal(sub + sub * .10, order.TotalCost);
        }
    }
}
