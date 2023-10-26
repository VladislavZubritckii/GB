public class Main {
    public static void main(String[] args) {
        String s1 = "hello world";
        String s2 = "dlrow olleh";
        StringBuilder stringBuilder = new StringBuilder(s2);
        if (s1.contentEquals(stringBuilder.reverse())) {
            System.out.println("Ok");
        }
    }
}