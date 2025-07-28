type State = {
  counter: number;
};

type Action = { type: "INCREMENT" } | { type: "DECREMENT" } | { type: "RESET" };

class Store {
  private state: State = { counter: 0 };
  private listeners: Function[] = [];

  getState() {
    return this.state;
  }

  subscribe(listener: Function) {
    this.listeners.push(listener);
  }

  dispatch(action: Action) {
    switch (action.type) {
      case "INCREMENT":
        this.state.counter++;
        break;
      case "DECREMENT":
        this.state.counter--;
        break;
      case "RESET":
        this.state.counter = 0;
        break;
    }
    this.listeners.forEach(fn => fn(this.state));
  }
}

export const store = new Store();
