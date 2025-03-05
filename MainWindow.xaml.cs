using System.Windows;

namespace Lab5_ProductCategories;

//Scaffold command used to generate the models/context for this lab
//scaffold-dbcontext "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False" Microsoft.EntityFrameworkCore.SqlServer -outputdir Models/Generated -contextdir Data -namespace Lab5_ProductCategories.Models -contextnamespace Lab5_ProductCategories.Data -Tables Products, Categories, Suppliers -DataAnnotations -force

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
}