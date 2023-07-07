using EFCodeFirst;

class program
{
    public static void Main(string[] args)
    {
       CRUDOperations crud = new CRUDOperations();
        // crud.InsertRecordsInStudentEntity();
        // crud.InsertRecordsInCourseEntity();
        // crud.UpdateRecordsInStudentEntity();
        //crud.DeleteRecordsInStudentEntity();
        crud.ReadDataFromStudentEntity("abi");

    }
}
