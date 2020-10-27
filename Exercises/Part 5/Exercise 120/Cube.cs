using System;

public class Cube
{
	public int CubeEdge { get; set; }

	public Cube(int edgeLength)
	{
		this.CubeEdge = edgeLength;
	}

	public int Volume()
    {
		int volume = this.CubeEdge * this.CubeEdge * this.CubeEdge;
		return volume;
    }

    public override string ToString()
    {
		return $"The length of the edge is {this.CubeEdge} and the volume is {this.Volume()}";
    }
}
