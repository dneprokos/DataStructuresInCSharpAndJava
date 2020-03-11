package implementations.stack;

import java.util.Stack;

public class StackExample {
    public static void baseExample() {
        Stack<String> stack = new Stack<>();
        stack.push("Test1");
        stack.push("Test2");
        stack.push("Test3");
        //Get top without removing
        stack.peek();
        //Remove from the top
        stack.pop();
        //Size
        stack.size();
        //Remove all
        stack.clear();
    }
}
