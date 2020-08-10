using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TDDWeek6;

namespace TDDWeek6.Tests
{
    public class ProductTests
    {

        [Fact]
        public void AddABook()
        {
            List<Product> comicBookList = new List<Product>();

            comicBookList.Add(new Product("Spiderman", "Book", "Thwip", (decimal)3.99));

            Dictionary<Product, int> comicBookCart = new Dictionary<Product, int>();

            comicBookCart[comicBookList[0]] = 3;

            Dictionary<Product, int> cartResult = Cart.AddToCart(comicBookList[0], 3);

            Assert.Equal(comicBookCart, cartResult);
        }

        //[Fact]
        //public void CalculateSubTotalTest()
        //{
        //    List<Product> comicBookList = new List<Product>();

        //    comicBookList.Add(new Product("Spiderman", "Book", "Thwip", (decimal)3.99));

        //    Dictionary<Product, int> comicBookCart = Cart.AddToCart(comicBookList[0], 3);

        //    decimal subTotalResult = Cart.CalculateSubTotal(comicBookCart);

        //    Assert.Equal((decimal)11.97, subTotalResult);

        //}

        //[Fact]
        //public void CalculateSalesTaxTest()
        //{
        //    List<Product> comicBookList = new List<Product>();

        //    comicBookList.Add(new Product("Spiderman", "Book", "Thwip", (decimal)3.99));

        //    Dictionary<Product, int> comicBookCart = Cart.AddToCart(comicBookList[0], 3);

        //    decimal subTotalResult = Cart.CalculateSubTotal(comicBookCart);

        //    decimal salesTaxResult = Cart.CalculateSalesTax(subTotalResult);

        //    Assert.Equal((decimal)0.72, Math.Round(salesTaxResult, 2));
        //}

        [Fact]
        public void CalculateGrandTotalTest()
        {
            List<Product> comicBookList = new List<Product>();

            comicBookList.Add(new Product("Spiderman", "Book", "Thwip", (decimal)3.99));

            Dictionary<Product, int> comicBookCart = Cart.AddToCart(comicBookList[0], 3);

            decimal subTotalResult = Cart.CalculateSubTotal(comicBookCart);

            decimal salesTaxResult = Cart.CalculateSalesTax(subTotalResult);

            decimal grandTotal = Cart.CalculateGrandTotal(subTotalResult, salesTaxResult);

            Assert.Equal((decimal)12.69, Math.Round(grandTotal, 2));
        }
    }
}
