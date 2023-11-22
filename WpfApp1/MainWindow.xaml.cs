using System;
using System.Collections.Generic;

namespace FoodOrderingSystem

 string item = $"Категория: {expense.Category}, Сумма: {expense.Amount}";           
statsListBox.Items.Add(item);      


public class Expense
{
    public double Amount { get; set; }
    public string Category { get; set; }
    public Expense(double amount, string category)
    {
        Amount = amount; Category = category;
    }
}
