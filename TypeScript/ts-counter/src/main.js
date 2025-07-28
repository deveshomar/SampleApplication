"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const store_1 = require("./store");
// DOM elements
const countElement = document.getElementById("counter");
const incBtn = document.getElementById("inc");
const decBtn = document.getElementById("dec");
const resetBtn = document.getElementById("reset");
// Subscribe to state changes
store_1.store.subscribe((state) => {
    countElement.textContent = state.counter.toString();
});
// Event handlers
incBtn.addEventListener("click", () => store_1.store.dispatch({ type: "INCREMENT" }));
decBtn.addEventListener("click", () => store_1.store.dispatch({ type: "DECREMENT" }));
resetBtn.addEventListener("click", () => store_1.store.dispatch({ type: "RESET" }));
// Initialize display
countElement.textContent = store_1.store.getState().counter.toString();
