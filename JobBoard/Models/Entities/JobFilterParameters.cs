namespace JobBoard.Models;
public class JobFilterParameters
{
      public string? search { get; set; }
      public int start { get; set; } = 1;
      public int end { get; set; } = 10;


}