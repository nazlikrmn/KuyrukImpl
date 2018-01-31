package pac;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Fifo f=new Fifo();
		lifo l=new lifo();
		for (int i = 0; i < 10; i++) {
			f.Ekle(i+1+"");
			l.Ekle(i+1+"");
		}
		
		l.KuyruguTemizle();
		f.KuyruguTemizle();
	}
	
}
