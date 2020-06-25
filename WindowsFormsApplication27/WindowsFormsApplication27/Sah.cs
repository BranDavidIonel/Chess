using System;
using System.Drawing;

class Piesa
{
   protected Image img;
   protected int x, y, w, h;
    public Piesa(int x, int y, int w, int h, Image img)
    {
        this.x = x;
        this.y = y;
        this.w = w;
        this.h = h;
        this.img = img;
    }
     public int X
    {
        get { return x; }
    }
    public int Y
    {
        get { return y; }
    }
    public void muta(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public void deseneaza(Graphics g)
    {
        g.DrawImage(img, x, y, w, h);
    }
    public bool esteDeasupra(int x, int y)
    {
        if (x < this.x || x > this.x + h)
            return false;
        if (y < this.y || y > this.y + h)
            return false;
        return true;

   
    }
}

class Pion: Piesa
{
    public Pion(int x, int y, int w, int h, Image img) : base(x, y, w, h, img)
    {

    }

}
class Cal : Piesa
{
    public Cal(int x, int y, int w, int h, Image img) : base(x, y, w, h, img)
    {

    }

}
class Nebun : Piesa
{
    public Nebun(int x, int y, int w, int h, Image img) : base(x, y, w, h, img)
    {

    }

}
class Tura : Piesa
{
    public Tura(int x, int y, int w, int h, Image img) : base(x, y, w, h, img)
    {

    }

}
class Rege : Piesa
{
    public Rege(int x, int y, int w, int h, Image img) : base(x, y, w, h, img)
    {

    }

}
class Regina : Piesa
{
    public Regina(int x, int y, int w, int h, Image img) : base(x, y, w, h, img)
    {

    }

}
class AlegePiesa
{
   public void Alege()
    {
        
    }
    
}