		if (ValidIPs.Contains(Ip.Split(',')[0]))
        {
            // Get the XML data from the request
            byte[] bArr = this.Request.BinaryRead(this.Request.TotalBytes);
            string content = System.Text.Encoding.UTF8.GetString(bArr, 0, bArr.Length);
            //Parse the XML to an instance object and insert it into the database
            Models.NotificationModel tm;
            if (Models.NotificationModel.TryParse(content, out tm))
            {
                tm.PostedDateTime = DateTime.Now.ToString();
                Models.NotificationDataSource data = new Models.NotificationDataSource();
                data.Insert(tm);
            }
        }
    }
}