import java.util.Scanner;

class Program {

    public static void main(String[] args) {
//        first();
//        second();
//        third();
//        four();
//        five();
//        six();
//        seven();
//        eight();
//        n9n9();
        tttnnn();
    }


    public static void first(){
        Scanner n = new Scanner(System.in);
        System.out.print("Enter int: ");
        int num = n.nextInt();

        if(num < 0){ System.out.print(num + " - less th 0");}
        else{System.out.print(num + " - dnt less th 0");}
    }

    public static void second(){
        Scanner s = new Scanner(System.in);
        System.out.print("Enter str: ");
        String str = s.nextLine();
        System.out.print(str.charAt(str.length()-1));
    }

    public static void third(){
        Scanner n = new Scanner(System.in);
        System.out.print("Enter int: ");
        int num = n.nextInt();
        num = Math.abs(num);
        while (num >= 10) {
            num /= 10;
        }
        System.out.print(num);
    }

    public static void four(){
        Scanner n = new Scanner(System.in);
        System.out.print("Enter int: ");
        int num = n.nextInt();
        num = Math.abs(num);

        int num1 = num;
        while (num1 >= 10) {
            num1 /= 10;
        }

        int num2 = num % 10;
        System.out.print(num1+num2);
    }

    public static void five(){
        Scanner n = new Scanner(System.in);
        System.out.print("Enter int: ");
        int num1 = n.nextInt();
        num1 = Math.abs(num1);

        Scanner n2 = new Scanner(System.in);
        System.out.print("Enter int: ");
        int num2 = n.nextInt();

        num2 = Math.abs(num2);

        while (num1 >= 10) {
            num1 /= 10;
        }
        while (num2 >= 10) {
            num2 /= 10;
        }

        if(num1==num2){System.out.print("Same");}
        else{System.out.print("Not same");}
    }

    public static void six(){
        Scanner n = new Scanner(System.in);
        System.out.print("Enter int: ");
        int num1 = n.nextInt();
        num1 = Math.abs(num1);

        Scanner n2 = new Scanner(System.in);
        System.out.print("Enter int: ");
        int num2 = n.nextInt();

        System.out.print(num1%num2);
    }

    public static void seven() {
        String str = "abcde";

        for (int i = str.length() - 1; i >= 0; i--) {
            System.out.println(str.charAt(i));
        }
    }

    public static void eight() {
        for (int i = 1; i <= 100; i++) {
            if (i % 3 == 0) {
                System.out.println(i);
            }
        }
    }

    public static void n9n9(){
        char chr1 = '1';
        char chr2 = '2';
        char chr3 = '3';

        int int1 = Character.getNumericValue(chr1);
        int int2 = Character.getNumericValue(chr2);
        int int3 = Character.getNumericValue(chr3);

        System.out.print(int1+int2+int3);
    }

    public static void tttnnn(){
        Scanner n = new Scanner(System.in);
        System.out.print("Enter int: ");
        int num = n.nextInt();

        for (int i = 1; i <= num; i++) {
            System.out.println("2^" + i + " = " + (int) Math.pow(2, i));
        }
    }
}