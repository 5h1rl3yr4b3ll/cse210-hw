using System;
using System.Collections.Generic;
using System.IO;

public class Product
{
    private string _nameProduct;
    private int _productId;
    private float _price;
    private int _quantity;

    public Product(string nameProduct, int productId, float price, int quantity)
    {
        _nameProduct = nameProduct;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Getter method for Packing Label
    public string GetNameProduct()
    {
        return _nameProduct;
    }

    // Getter method for Packing Label 
    public int GetProductId()
    {
        return _productId;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
    public float TotalCost()
    {
        return _price * _quantity;
    }

}