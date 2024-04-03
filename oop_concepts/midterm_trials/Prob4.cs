/*
1) Photobook
    - priv att 


*/


internal class PhotobookTest{
    // public static void Main(string[] args){
    //     Photobook defPhoto = new Photobook();
    //     Console.WriteLine($"Default Photobook Pages: {defPhoto.GetNumberPages()}");

    //     Photobook specifiedPhoto = new Photobook(24);
    //     Console.WriteLine($"Specified Pages: {specifiedPhoto.GetNumberPages()}");

    //     BigPhotoBook bigPhoto = new BigPhotoBook();
    //     Console.WriteLine($"Big Photobook: {bigPhoto.GetNumberPages()}");
        
    

    // }

}


internal class Photobook{
    protected int numPages;

    public int GetNumberPages(){
        return numPages;
    }

    public Photobook(){
        numPages = 16;
    }

    public Photobook(int numPages){
        this.numPages = numPages;
    }

}

internal class BigPhotoBook : Photobook{
    public BigPhotoBook(){
        numPages = 64;
    }
}