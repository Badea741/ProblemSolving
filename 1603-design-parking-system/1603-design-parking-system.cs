public class ParkingSystem {
    
    int big;
    int medium;
    int small;

    public ParkingSystem(int big, int medium, int small) {
        if(big>=1)this.big+=big;
        if(medium>=1)this.medium+=medium;
        if(small>=1)this.small+=small;
    }
    
    public bool AddCar(int carType) {
       if(carType==1&&this.big>=1){
           this.big--;
           return true;
       }
        if(carType==2&&(this.medium>=1)){
            this.medium--;
            return true;
        }
        if(carType==3&&(this.small>=1)){
            this.small--;
            return true;
        }
        return false;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */