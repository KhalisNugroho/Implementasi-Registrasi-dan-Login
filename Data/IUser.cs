using System;
using SecureWeb.Models; 

namespace SecureWeb.Data;

public interface IUser
{
    User Registration(User user);
    User Login(User user);
}
