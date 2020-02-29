package implementations.arrayLists;

public class SimpleClass {
    public SimpleClass(String fullName, int age) {
        this.fullName = fullName;
        this.age = age;
    }

    private String fullName;
    private int age;

    public String getFullName() {
        return fullName;
    }

    public void setFullName(String fullName) {
        this.fullName = fullName;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }
}
