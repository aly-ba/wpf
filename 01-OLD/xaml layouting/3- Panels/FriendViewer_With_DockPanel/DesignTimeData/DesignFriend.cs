using FriendViewer.Model;
using System;
using System.Windows;

namespace FriendViewer.DesignTimeData
{
    public class DesignFriend : Friend
    {
        public DesignFriend()
        {
            FirstName = "Thomas";
            LastName = "Huber";
            CellPhone = "+49 (0) 123456789";
            Email = "thomas@thomasclaudiushuber.com";
            Homepage = "www.thomasclaudiushuber.com";
            SetImageProperty();
        }

        private void SetImageProperty()
        {
            var streamResourceInfo = 
                Application.GetResourceStream(
                new Uri("FriendViewer;component/DesignTimeData/Images/thomas.jpg", UriKind.Relative));

            var length = streamResourceInfo.Stream.Length;
            byte[] image = new byte[length];
            streamResourceInfo.Stream.Read(image, 0, (int)length);

            Image = image;
        }
    }
}
