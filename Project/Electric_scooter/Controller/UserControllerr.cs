using Electric_scooter.Entity;
using Electric_scooter.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Electric_scooter.Controller;


[ApiController]
[Route("api/users")]
public class UserControllerr
{

    private readonly IConfiguration _configuration;
    public UserControllerr(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    [HttpPost("create")]
    public string CreateUser([FromBody] UserEntity request)
    {
        var conString = _configuration.GetConnectionString("Default");
        SqlConnection conn = new SqlConnection(conString);
        conn.Open();
        var sql =
            "INSERT INTO tbl_user(first_name,last_name,username,password,email) VALUES (@first_name,@last_name,@username,@password,@email)";
        SqlCommand cd = new SqlCommand(sql, conn);
        cd.Parameters.AddWithValue("@first_name",request.first_name);
        cd.Parameters.AddWithValue("@last_name",request.last_name);
        cd.Parameters.AddWithValue("@email",request.email);
        cd.Parameters.AddWithValue("@username",request.username);
        var helper = new GeneralHelpers();
        var hashedPassword = helper.HashPassword(request.password);
        cd.Parameters.AddWithValue("@password",hashedPassword);
        var affectedRow = cd.ExecuteNonQuery();
        if (affectedRow > 0)
        {
            return "Success Create user";
        }

        return "";
    }
    [HttpGet]
    public string GetUsers()
    {
        return "";
    }

    [HttpPut("update")]
    public string UpdateUser()
    {
        return "";
    }
    
    [HttpDelete("delete")]
    public string DeleteUser()
    {
        return "";
    }
}