using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Electric_scooter.Entity;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Data.SqlClient;

namespace Electric_scooter.Controller;

[ApiController] 
[Route("products")]

public class ProductController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public ProductController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet("list")]
    public async Task<IActionResult> GetProductForFe()
    {
        var products = new List<ElectricScooterEntity>();
        
        var strCon = _configuration.GetConnectionString("Default");
        SqlConnection conn = new SqlConnection(strCon);
        conn.Open();
        var sql = "SELECT *FROM tbl_product ORDER BY id DESC";
        SqlCommand command = new SqlCommand(sql, conn);
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            var id = reader.GetInt32(reader.GetOrdinal("id"));
            var title = reader.GetString(reader.GetOrdinal("title"));
            var description = reader.GetString(reader.GetOrdinal("description"));
            string price = reader.GetString(reader.GetOrdinal("price"));
            var image = reader.GetString(reader.GetOrdinal("image"));
            var cat_id = reader.GetInt32(reader.GetOrdinal("cat_id"));
            var product = new ElectricScooterEntity();
            product.id = id;
            product.title = title;
            product.description = description;
            product.image = image;
            product.price = price;
            product.cat_id = cat_id;

            products.Add(product);
        }

        return Ok(products);
    }
    
    [HttpGet] 
    public object GetProducts()
    {
        var products = new List<ElectricScooterEntity>();
            
        try
        {
            var connectionString = _configuration.GetConnectionString("Default");
            // create connection to sql server
            SqlConnection connection = new SqlConnection(connectionString);
            var sql = " SELECT *FROM tbl_product";
            SqlCommand cd = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = cd.ExecuteReader();
            while (reader.Read())
            {
                var id = reader.GetInt32(reader.GetOrdinal("id"));
                var title = reader.GetString(reader.GetOrdinal("title"));
                var description = reader.GetString(reader.GetOrdinal("description"));
                var price = reader.GetString(reader.GetOrdinal("price"));
                var image = reader.GetString(reader.GetOrdinal("image"));
                var cat_id = reader.GetInt32(reader.GetOrdinal("cat_id"));
                var product = new ElectricScooterEntity();
                product.id = id;
                product.title = title;
                product.description = description;
                product.price = price;
                product.cat_id = cat_id;
                product.image = string.IsNullOrWhiteSpace(image) ? "" : image;
                products.Add(product);
            }
        }
        catch (Exception ex)
        {
            var error = ex.Message;
        }
        return products;
        
    }
    
    // Create
    [HttpPost("create")]
    public string CreateProduct([FromBody] ElectricScooterEntity request)
    {
        try
        {
            var connectionString = _configuration.GetConnectionString("Default");
            SqlConnection connection = new SqlConnection(connectionString);
            var sql = "INSERT INTO tbl_product(title,description,price,image,cat_id) VALUES(@title,@description,@price,@image,@cat_id)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@title",request.title);
            command.Parameters.AddWithValue("@description",request.description );
            command.Parameters.AddWithValue("@price",request.price );
            command.Parameters.AddWithValue("@image",request.image );
            command.Parameters.AddWithValue("@cat_id", request.cat_id);
            connection.Open();
            var rowsAffected= command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                return "Product create successful";
            }
            else
            {
                return "Error creating product";
            }
        }
        catch (Exception ex)
        {
            return $"Error creating product {ex.Message}";
        }
        return "Create"; 
    }
    
    // Delete
    [HttpDelete("delete")]
    public string DeleteProduct([FromBody] ElectricScooterEntity request)
    {
        try
        {
            var connectionString = _configuration.GetConnectionString("Default");
            SqlConnection connection = new SqlConnection(connectionString);
            var sql = "DELETE FROM tbl_furniture WHERE id=@id ";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@id", request.id);
            connection.Open();
            var rowaffected = command.ExecuteNonQuery();
            if (rowaffected > 0)
            {
                return "Delete Product Successfully";
            }
            else
            {
                return "Can not delete product";
            }

        }
        catch (Exception e)
        {
            return $"Delete Product fail {e.Message} ";
        }
    }

    // Update
    [HttpPut("update")]
    public string UpdateProduct([FromBody] ElectricScooterEntity request)
    {
        try
        {
            var connectionString = _configuration.GetConnectionString("Default");
            SqlConnection connection = new SqlConnection(connectionString);
            var sql = "UPDATE tbl_furniture SET title=@title , price=@price WHERE id=@id";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@title", request.title);
            command.Parameters.AddWithValue("@id", request.id);
            connection.Open();
            var rowaffected = command.ExecuteNonQuery();
            if (rowaffected > 0)
            {
                return "Product Updated successfully";
            }
            else
            {
                return "Can not update product";
            }
        }
        catch (Exception ex)
        {
            return $"Error Update Product {ex.Message} ";
        }
    }
    
    // Select Product
    [HttpGet("{id}")]
    public ElectricScooterEntity GetProductById(int id)
    {
        var product = new ElectricScooterEntity();
        try
        {
            var connectionString = _configuration.GetConnectionString("Default");
            SqlConnection connection = new SqlConnection(connectionString);
            var sql = "  SELECT *FROM tbl_product WHERE id=@id";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) 
            {
                reader.Read();
                int uId = reader.GetInt32(0);
                string title = reader.GetString(1);
                string des = reader.GetString(2);
                string pri = reader.GetString(3);
                string img = reader.GetString(4);
                int catid = reader.GetInt32(5);
                product.id = uId;
                product.title = title;
                product.description = des;
                product.price = pri;
                product.cat_id = catid;
                product.image = img;
            }
        }
        catch (Exception e)
        {
            var error = $"Error creating product {e.Message}";
        }

        return product;
    }
    
    // Upload
    [HttpPost("upload")]
    public async Task<IActionResult> UploadFile(IFormFile file)
    {
        if (file == null || file.Length == 0)
        {
            return BadRequest("No file uploaded.");
        }

        var uploadFolderPath = "//Users/kormtaiyi/Documents/ADITI_Academy/Frond-end Development/K-taiyi.github.io";

        var filePath = Path.Combine(uploadFolderPath, file.FileName);
        var stream = new FileStream(filePath, FileMode.Create);
        await file.CopyToAsync(stream);
        return Ok(new { filePath });
    }
    // Multi_Upload
    [HttpPost(template: "uploads")]
    public async Task<IActionResult> UploadFiles(IFormFileCollection files)
    {
        if (files == null || files.Count == 0)
        {
            return BadRequest("No files uploaded.");
        }

        var uploadFolderPath = "//Users/kormtaiyi/Documents/ADITI_Academy/Frond-end Development/K-taiyi.github.io";
        var uploadedFiles = new List<string>();

        foreach (var file in files)
        {
            var filePath = Path.Combine(uploadFolderPath, file.FileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            uploadedFiles.Add(filePath);
        }
        return Ok(new { uploadedFiles });
    }
}