using System.Collections;

public class Graph<ElementType>
{
	using GraphElement = Tuple<ElementType, ElementType>;

	public Graph() {}

	public void add(ElementType element)
	{
		m_vertices.Add(element);
	}

	public connect(ElementType element_l, ElementType element_r)
	{
		m_connections.Add(new GraphElement(element_l, element_r));
		m_connections.Add(new GraphElement(element_r, element_l));
	}

	// use HashSet to provide uniqueness of elements
	private HashSet<ElementType> m_vertices;
	private HashSet<GraphElement> m_connections;
}
