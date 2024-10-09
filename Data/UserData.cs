using System;
using SecureWeb.Models;
using BC = BCrypt.Net.BCrypt;

namespace SecureWeb.Data;

public class UserData : IUser
{
    private readonly ApplicationDbContext _db;
    public UserData(ApplicationDbContext db){
        _db=db;
    }
    public User Login(User user)
    {
        var _user = _db.User.FirstOrDefault(u => u.Username == user.Username);
        if (_user==null)
        {
            throw new Exception("User not found");
        }
        if (!BCrypt.Net.BCrypt.Verify(user.Password, _user.Password))
        {
            throw new Exception("Password is Incorrect");
        }
        return _user;
    }
    
    public User Registration(User user){
        try
        {
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            _db.User.Add(user);
            _db.SaveChanges();
            return user;
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
