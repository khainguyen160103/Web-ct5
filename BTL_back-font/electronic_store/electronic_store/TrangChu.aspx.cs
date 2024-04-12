using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace electronic_store
{
    public partial class TrangChu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Objects.products> listProductDD = (List<Objects.products>)Application["listProductDD"];
            string htmlDD = "";
            foreach (Objects.products product in listProductDD)
            {
                htmlDD += "<div class=\"deal - product - item col l-2 m - 4 c - 6\"> " +
                        "<img src = \"./Image/DealDay/"+product.image+".jpg\"" + " alt = \"+"+product.image+"\" class=\"deal-item-img\" />" +
                        "<span class=\"deal-item-dealOff\">"+ product.caculateDiscountPercentage()+"% OFF</span>" +
                        "<div class=\"deal-item-price\"> " +
                           " <span class=\"deal-price-origin\">"+product.price_discounted+"$</span> " +
                           " <span class=\"deal-price-saleOff\">"+product.price_origin+"$</span>" +
                        "</div>" +
                        "<div class=\"item-claimed\"> " +
                             "<div class=\"claimed-barBox\"> " +
                                "<div class=\"bar\"></div>" +
                            "</div>" +
                            "<span class=\"claimed-left\">"+product.sold+" left</span>" +
                        "</div>" +
                    "</div>";
            }
            dealProduct.InnerHtml = htmlDD;

            List<Objects.products> listProductN = (List<Objects.products>)Application["listProductN"];
            string htmlN = "";
            foreach (Objects.products product in listProductN)
            {
                htmlN +=   "<li class=\" col l-3 m-6 c-6\">" + 
                       " <div class=\"new-product-item\">" + 
                            "<a href = \"\" class=\"new-item-link\">" + 
                                "<img class=\"new-item-img\" src=\"./Image/NewItem/"+ product.image +".jpg\""+" alt=\"\"> " + 
                            "</a>"+
                            "<span class=\"new-item-header\">"+product.description+"</span>"+
                            "<span class=\"new-item-price\">"+product.price_origin+"$</span>"+
                        "</div>" +
                    "</li>";
            }
            newProduct.InnerHtml = htmlN;

            List<Objects.products> listProductBSL = (List<Objects.products>)Application["ListProduct_BSL"];
            string htmlBSL = "";
            foreach (Objects.products product in listProductBSL)
            {
                htmlBSL += "<li class=\" col l-2-4 m-4 c-12\">"+
                        "<div class=\"bestSeller-product-item\">"+
                            "<a href = \"\" class=\"bestSeller-item-link\">"+
                               "<img src = \"./Image/BestSeller/"+product.image+".jpg\""+" alt=\"\" class=\"bestSeller-item-img\">" +
                            "</a>" +
                            "<span class=\"bestSeller-item-saleOff\">"+product.caculateDiscountPercentage()+"% OFF</span>" +
                            "<div class=\"bestSeller-item-description\">"+product.description+"</div>" +
                            "<div class=\"bestSeller-rating\">" +
                               " <span class=\"rating-star\">" +
                                   " <i class=\"fa-solid fa-star\" style=\"color: #FFD43B;\"></i>" +
                                   " <i class=\"fa-solid fa-star\" style=\"color: #FFD43B;\"></i>" +
                                   " <i class=\"fa-solid fa-star\" style=\"color: #FFD43B;\"></i>" +
                                   " <i class=\"fa-solid fa-star\" style=\"color: #FFD43B;\"></i>" +
                                   " <i class=\"fa-solid fa-star\" style=\"color: #FFD43B;\"></i>" +
                                "</span>" +
                                "<span class=\"rating-sold\">"+product.sold+"</span>" +
                           " </div>" +
                            "<div class=\"bestSeller-item-price\">" +
                              "  <span class=\"price-discounted\">"+product.price_discounted+"$</span>" +
                               " <span class=\"price-origin\">"+product.price_origin+"$</span>" +
                           " </div>" +
                        "</div>" +
                   "</li>";
            }
            bestSellerProduct.InnerHtml = htmlBSL;
        }
    }
}