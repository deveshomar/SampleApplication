"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.store = void 0;
class Store {
    constructor() {
        this.state = { counter: 0 };
        this.listeners = [];
    }
    getState() {
        return this.state;
    }
    subscribe(listener) {
        this.listeners.push(listener);
    }
    dispatch(action) {
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
exports.store = new Store();
