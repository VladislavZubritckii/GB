public class Main {
    public static void main(String[] args) {
        String s1 = "sos";
        String s2 = "sosososos";
        int i = 0;
        while ( i <= s2.length()) {
            if (s2.indexOf(s1, i) != -1 ) {
                System.out.println(s2.indexOf(s1, i));
                i = s2.indexOf(s1, i) + 1;
            }
            if (i + s1.length() >= s2.length()) {
                break;
            }
        }
    }
}