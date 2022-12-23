var linkedListObj = {
  data: [],
  PushVal: function (value) {
    this.data.push({ val: value });
  },
  Enqueue: function (value) {
    if (this.data.length == 0) {
      this.PushVal(value);
    } else if (this.data[this.data.length - 1].val < value) {
      this.PushVal(value);
    } else if (this.data[this.data.length - 1].val > value) {
      throw new Error(" Out of sequence");
    }
  },
  Insert: function (value) {
    var exist = false,
      index = 0;
    if (this.data.length == 0) {
      this.data.unshift({ val: value });
    } else {
      for (var i = 0; i < this.data.length && exist == false; i++) {
        if (this.data[0].val > value) {
          this.data.unshift({ val: value });
          exist = true;
        } else if (this.data[this.data.length - 1].val < value) {
          this.Enqueue(value);
          exist = true;
        } else if (this.data[i].val == value) {
          exist = true;
          throw new Error("element already exits in the linked list");
        } else {
          if (this.data[i].val > value) {
            index = i;
            exist = true;
          }
        }
      }
    }

    if (index != 0) {
      /*var start = this.data.length;
      for (var i = start; i > index; i--) {
        if (i == start) {
          this.data.push({ val: this.data[i - 1].val });
        } else {
          this.data[i].val = this.data[i - 1].val;
        }
      }
      this.data[index].val = value;*/
      this.data.splice(i - 1, 0, { val: value });
    }
  },
  Pop: function () {
    this.data.pop();
  },
  Remove: function (value) {
    var flag = false;

    for (var i = 0; i < this.data.length && !flag; i++) {
      if (this.data[i].val == value) {
        this.data.splice(i, 1);
        flag = true;
      }
    }
    if (flag == false) {
      throw new Error("Data not found");
    }
  },
  Dequeue: function () {
    if (this.data.length != 0) {
      this.data.shift();
    } else {
      throw new Error("List is empty");
    }
  },
  display: function () {
    for (var i = 0; i < this.data.length; i++) {
      console.log(this.data[i].val);
    }
  },
};

linkedListObj.Insert(5);
linkedListObj.Insert(9);
linkedListObj.Insert(1);
linkedListObj.Insert(10);
linkedListObj.Insert(3);
linkedListObj.Insert(7);
linkedListObj.Insert(20);
linkedListObj.Insert(19);
linkedListObj.Insert(33);
linkedListObj.Insert(60);
//linkedListObj.Insert(9);
//linkedListObj.Insert(1);

linkedListObj.display();

linkedListObj.Dequeue();
linkedListObj.Dequeue();
linkedListObj.Dequeue();
linkedListObj.Dequeue();
console.log("-------------------------- after dequeue");
linkedListObj.display();
linkedListObj.Remove(9);
linkedListObj.Remove(10);
console.log("---------------------------- after remove");
linkedListObj.display();
linkedListObj.Pop();
console.log("------------------------after pop");
linkedListObj.display();
