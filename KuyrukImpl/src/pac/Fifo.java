package pac;

public class Fifo extends Queue {

	public String[] kuyruk=new String[10];
	@Override
	public void Ekle(String val) {
		// TODO Auto-generated method stub
		for(int i=0;i<kuyruk.length;i++) {
			if(kuyruk[i]==null) {
				kuyruk[i]=val;
				System.out.println(val+" Eklendi.(fifo)");
				break;
			}
			if(kuyruk[i]!=null && i==kuyruk.length) {
				System.out.println("Kuyruk Dolu(fifo)");
			}
		}
	}

	@Override
	public void KuyruguTemizle() {
		// TODO Auto-generated method stub
		for(int i=0;i<kuyruk.length;i++) {
			if(kuyruk[i]==null && i==0)
				System.out.println("Kuyruk Boþ(fifo)");
			if(kuyruk[i]!=null) {
				System.out.print(kuyruk[i]+"\t");
				kuyruk[i]=null;
			}
		}
	}
	
}
