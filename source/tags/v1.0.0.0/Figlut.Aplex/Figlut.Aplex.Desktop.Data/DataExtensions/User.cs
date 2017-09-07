namespace Figlut.Aplex.Desktop.Data.WebService
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using Figlut.Aplex.Desktop.Data;

    #endregion //Using Directives

    public partial class User
    {
        #region Constructors

        public User()
        {
            _userPermissionCache = new UserPermissionCache();
        }

        #endregion //Constructors

        #region Fields

        private UserPermissionCache _userPermissionCache;

        #endregion //Fields

        #region Properties

        public UserPermissionCache UserPermissionCache
        {
            get { return _userPermissionCache; }
        }

        #endregion //Properties

        #region Methods

        public User Clone()
        {
            User result = new User()
            {
                UserId = this.UserId,
                UserName = this.UserName,
                Password = this.Password,
                RoleId = this.RoleId,
                Name = this.Name,
                Surname = this.Surname,
                Email = this.Email,
                Address = this.Address,
                Phone = this.Phone,
                EmailNotifications = this.EmailNotifications,
                DateCreated = this.DateCreated
            };
            foreach (UserPermission p in this.UserPermissionCache)
            {
                result.UserPermissionCache.Add(new UserPermission()
                {
                    UserPermissionId = p.UserPermissionId,
                    PermissionName = p.PermissionName,
                    UserId = p.UserId,
                    DateCreated = p.DateCreated
                });
            }
            return result;
        }

        public void CopyTo(User user)
        {
            user.UserId = this.UserId;
            user.UserName = this.UserName;
            user.Password = this.Password;
            user.RoleId = this.RoleId;
            user.Name = this.Name;
            user.Surname = this.Surname;
            user.Email = this.Email;
            user.Address = this.Address;
            user.Phone = this.Phone;
            user.EmailNotifications = this.EmailNotifications;
            user.DateCreated = this.DateCreated;

            user.UserPermissionCache.Clear();
            foreach (UserPermission p in this.UserPermissionCache)
            {
                user.UserPermissionCache.Add(new UserPermission()
                {
                    UserPermissionId = p.UserPermissionId,
                    PermissionName = p.PermissionName,
                    UserId = p.UserId,
                    DateCreated = p.DateCreated
                });
            }
        }

        #endregion //Methods
    }
}
