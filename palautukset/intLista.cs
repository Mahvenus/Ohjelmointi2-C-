class IntLista{
  // tietorakenne, array
  public int[] luvut = new int[10];  
  // ominaisuus/muuttujat, isolla kirjaimella
  private int _count = 0;
  public int Count { 
    get => _count;  
    private set => _count = value; 
    }
    
  // metodi/toiminnallisuus/funktio, julkisia, isolla kirjaimella
  public void Add (int luku){
    luvut[Count] = luku;
    Count ++;
  }
  public bool Remove (int luku) {
    for (int i = 0; i < Count; i++)
    {
      if (luvut[i] == luku) 
      {
        luvut[i] = 0;
        Count --;
        return true;
      }
    }
    return false;
  }
  public void Clear (){
    for (int i = 0; i < Count; i++) 
    {
      luvut[i] = 0;
      Count --;
    }
  }
  public  bool Contains (int luku){
    for (int i = 0; i < Count; i++)
    {
      if (luvut[i] == luku)
      {
      return true;
      }
    }
    return false;
  } 
}