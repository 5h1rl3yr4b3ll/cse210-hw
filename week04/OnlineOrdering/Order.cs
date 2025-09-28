using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer) {
        _customer = customer;
    }

    public void AddProducts(Product product)
    {
        _products.Add(product);
    }
    public float TotalPrice()
    {
        float _totalPrice = 0;
        foreach (Product product in _products)
        {
            _totalPrice += product.TotalCost();
        }

        float _shippingCost = 0;
        if (_customer.InUsa()== true){
            _shippingCost = 5;
        }
        else {
            _shippingCost = 35;
        }

        return _totalPrice + _shippingCost ;
    }

    public string GetPackingLabel()
    {
        string header = "--- Packing Slip ---\n";
        string productDetails = "";
        
        foreach (Product product in _products)
        {
            // Appends details for each product on a new line.
            productDetails += $"Product: {product.GetNameProduct()} | ID: {product.GetProductId()} | Qty: {product.GetQuantity()}\n";
        }

        // Returns the combined header and product details.
        return header + productDetails;
    }

    public string ShippingLabel()
    {
        return $"--- Shipping Label --- \nShip To: {_customer.GetName()} \n Address:\n {_customer.GetAddressString()}";
    }

}