
using System.Data.SQLite;
using System.Reflection.PortableExecutable;

CreateConnection();

static SQLiteConnection CreateConnection()

{
    SQLiteConnection connection = new SQLiteConnection("Data Source=bar.db; Version=3; New = True; Compress = true");
    try
    {
        connection.Open();
        Console.WriteLine("DB found.");
    }
    catch
    {
        Console.WriteLine("DB not found.");
    }
    return connection;

}

static void DisplayProduct(SQLiteConnection myConnection)
{

    reader;

    command;

    command = myConnection.
();

    command.CommandText = "SELECT rowid, 
, 
 FROM product";
    reader = command.
();


    (reader.
   ())
    {

        string readerRowid = reader["rowid"].ToString();
        string readerProductName = reader.GetString(
);
        int readerProductPrice = reader.GetInt32(
); //hinna tüüp andmebaasis on int, nii et siin loeme andmebaasis ka int-tüüpi andmeid

        Console.WriteLine($"{readerRowid}. {readerProductName}. Price: {readerProductPrice}");
    }
    
.
();
}







//static void FindCustomer(SQLiteConnection myConnection)
//{
//    SQLiteDataReader reader;
//    SQLiteCommand command;
//    string searchName;
//    Console.WriteLine("Enter a first name to display customer data:");

//    searchName = Console.ReadLine();
//    command = myConnection.CreateCommand();
//    command.CommandText = $"SELECT customer. Rowid , customer. Name , customer. LastName , status. Status  " +
//        $"FROM customerStatus " +
//        $"JOIN customer ON customer. rowid  = customerStatus.customerId " +
//        $"JOIN status ON status.rowid = customerStatus. customerId  " +
//        $"WHERE firstname LIKE '{searchName}'";
//    reader = command.ExecuteReader();

//    while
//     (reader.Read())
//    {
//        string readerRowid = reader["rowid"].ToString();
//        string readerStringFirstName = reader.GetString(0);
//        string readerStringLastName = reader.GetString(1);
//        string readerStringStatus = reader.GetString(2);
//        Console.WriteLine($"Search result: ID: {readerRowid}. {readerStringFirstName} {readerStringLastName}. Status: {readerStringStatus}");
//    }

//    myConnection.Close();
//}


//FindCustomer(CreateConnection());













//ReadData(CreateConnection());
//// InsertCustomer(CreateConnection());
//// RemoveCustomer(CreateConnection());
///*FindCustomer() */ // Siia lisada koduses töös käsklusesse juurde

//static SQLiteConnection CreateConnection()

//{
//SQLiteConnection connection = new SQLiteConnection("Data Source=bar.db; Version=3; New = True; Compress = true");

//try
//{
//    connection.Open();
//    Console.WriteLine("DB found.");
//    }
//catch
//{
//    Console.WriteLine("DB not found.");
//}

//return connection;

// }


//// 3 video

//static void ReadData(SQLiteConnection myConnection)
//{
//    Console.Clear();
//    SQLiteDataReader reader;
//    SQLiteCommand command;

//    command = myConnection.CreateCommand();
//    command.CommandText = "SELECT rowid, * FROM customer";

//    reader = command.ExecuteReader();

//    while (reader.Read())
//    {
//        int readerRowid = reader.GetInt32(0);
//        string readerStringFirstName = reader.GetString(1);
//        string readerStringLastName = reader.GetString(2);
//        string readerStringDoB = reader.GetString(3);

//        Console.WriteLine($"{readerRowid}. Full name: {readerStringFirstName} {readerStringLastName}; DoB:{readerStringDoB}");
//    }
//    myConnection.Close();
//}

//static void InsertCustomer(SQLiteConnection myConnection)
//{
//    SQLiteCommand command;
//    string fName, lName, dob;

//    Console.WriteLine("Enter first name:");
//    fName = Console.ReadLine();
//    Console.WriteLine("Enter last name:");
//    lName = Console.ReadLine();
//    Console.WriteLine("Enter date of birt (mm-dd-yyyy:");
//    dob = Console.ReadLine();

//    command = myConnection.CreateCommand();
//    command.CommandText = $"INSERT INTO customer (firstName, lastName, dateOfBirth) VALUES ('{fName}', '{lName}', '{dob}')";


//    int rowInserted = command.ExecuteNonQuery();
//    Console.WriteLine($"Row inserted: {rowInserted}");

//    ReadData(myConnection);
//}

//static void RemoveCustomer(SQLiteConnection myConnection)
//{
//    SQLiteCommand command;

//    string idToDelete;
//    Console.WriteLine("Enter an id to delete a customer:");
//    idToDelete = Console.ReadLine();

//    command = myConnection.CreateCommand();
//    command.CommandText = $"DELETE FROM customer WHERE rowid = {idToDelete}";
//    int rowRemoved = command.ExecuteNonQuery();

//    Console.WriteLine($"{rowRemoved} was removed from the table customer.");

//    ReadData(myConnection);
//}


////static void FindCustomer()  // kodutöös
////{ }