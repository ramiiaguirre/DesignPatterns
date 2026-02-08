namespace Composite;

//Composite
public class MixedTopography : Topography
{
	List<Topography> elements;
	public MixedTopography(Topography t1, Topography t2,
				Topography t3, Topography t4) 
	{
		elements = new List<Topography>();
		elements.Add(t1);
		elements.Add(t2);
		elements.Add(t3);	
		elements.Add(t4);	
	}




}

