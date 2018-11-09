﻿namespace XamarinToDoApp
{
    public static class Constants
    {
        // **** Realm Cloud Users:
        // **** Replace MY_INSTANCE_ADDRESS with the hostname of your cloud instance
        // **** e.g., "mycoolapp.us1.cloud.realm.io"
        // ****
        // ****
        // **** ROS On-Premises Users
        // **** Replace the AUTH_URL and REALM_URL strings with the fully qualified versions of
        // **** address of your ROS server, e.g.: "http://127.0.0.1:9080" and "realm://127.0.0.1:9080"

        public static string MY_INSTANCE_ADDRESS = "awesome-metal-cheese.us1.cloud.realm.io"; // <- update this


        public static string AUTH_URL = string.Format("https://{0}", MY_INSTANCE_ADDRESS);
        public static string REALM_URL = string.Format("realms://{0}/ToDo", MY_INSTANCE_ADDRESS);

    }
}