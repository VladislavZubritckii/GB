public class Main {
    public static void main(String[] args) {
        String str = "";
        StringBuilder stringBuilder = new StringBuilder(50000);
        long start = System.currentTimeMillis();
        for (int i = 0; i < 50000; i++) {
            str += Character.getName(i);
        }
        long end = System.currentTimeMillis();
        System.out.println(end - start);

        start = System.currentTimeMillis();
        for (int i = 0; i < 50000; i++) {
            stringBuilder.append(Character.getName(i));
        }
        end = System.currentTimeMillis();
        System.out.println(end - start);
    }
}