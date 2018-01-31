package pac;

public class lifo extends Queue {

	public String[] kuyruk=new String[10];
	@Override
	public void Ekle(String val) {
		// TODO Auto-generated method stub
		for(int i=0;i<kuyruk.length;i++) {
			if(kuyruk[i]==null) {
				kuyruk[i]=val;
				System.out.println(val+" Eklendi.(lifo)");
				break;
			}
			if(kuyruk[i]!=null && i==kuyruk.length) {
				System.out.println("Kuyruk Dolu(lifo)");
				break;
			}
		}
	}

	@Override
	public void KuyruguTemizle() {
		// TODO Auto-generated method stub
		for(int i=kuyruk.length-1;i>=0;i--) {
			if(kuyruk[i]==null&&i==0)
				System.out.println("Kuyruk Boþ(lifo)");
			if(kuyruk[i]!=null) {
				System.out.print(kuyruk[i]+"\t");
				kuyruk[i]=null;
			}
		}
		System.out.println();
	}

}
