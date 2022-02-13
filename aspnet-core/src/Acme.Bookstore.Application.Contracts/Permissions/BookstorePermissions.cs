﻿namespace Acme.Bookstore.Permissions;

public static class BookstorePermissions
{
    public const string GroupName = "Bookstore";

    public static class Books
    {
        public const string Default = GroupName + ".Books";
        public const string Create = GroupName + ".Create";
        public const string Edit = GroupName + ".Edit";
        public const string Delete = GroupName + ".Delete";
    }
    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
}
