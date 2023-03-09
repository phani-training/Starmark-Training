using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for ProductService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class ProductService : System.Web.Services.WebService
{
    const string STRCONNECTION = "Data Source=192.168.171.36;Initial Catalog=Phaniraj-CSMM40;Integrated Security=True";
    const string STRSTATEMENT = "SELECT * FROM PRODUCT";
    public ProductService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Bye World";
    }
    [WebMethod]
    public DataTable GetAllProducts()
    {
        SqlDataAdapter ada = new SqlDataAdapter(STRSTATEMENT , STRCONNECTION);
        DataSet ds = new DataSet("Data");
        ada.Fill(ds, "Data");
        return ds.Tables["Data"];
    }

}
