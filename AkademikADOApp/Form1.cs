using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AkademikADOApp
{
    public partial class Form1 : Form
    {
        //Connection String
        string connString =
        "Data Source=VILHAZEEE\\YAEMIKO;Initial Catalog=DBAkademikADO;Integrated Security=True";
        //Object SqlConnection
        SqlConnection conn;


