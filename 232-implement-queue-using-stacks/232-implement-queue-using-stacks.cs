public class MyQueue {
   Stack stack1 ;
    Stack stack2;

    public MyQueue() {
        stack1=new();
        stack2=new();
    }
    
    public void Push(int x) {
        stack1.Push(x);
    }
    
    public int Pop() {
        while(stack1.Count!=1){
            stack2.Push(stack1.Pop());
        }
        dynamic returnValue=stack1.Pop();
        while(stack2.Count!=0){
            stack1.Push(stack2.Pop());
        }
        return returnValue;
        
    }
    
    public int Peek() {
        while(stack1.Count!=1){
            stack2.Push(stack1.Pop());
        }
        dynamic returnValue=stack1.Peek();
        while(stack2.Count!=0){
            stack1.Push(stack2.Pop());
        }
        return returnValue;
    }
    
    public bool Empty() {
        return stack1.Count==0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */