string[] orderID = ["B123","C234","A345","C15","B177","G3003","C235","B179"];
List<string> susIDs = new List<string>();

foreach(string id in orderID){
    if(id.StartsWith("B")){
        susIDs.Add(id);
    }
}
foreach(string id in susIDs){
    Console.WriteLine($"{id} is sus. Theres a total of {susIDs.Count} sus orders.");
}
