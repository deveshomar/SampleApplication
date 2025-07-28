import { store } from "./store";
// DOM elements
const countElement = document.getElementById("counter");
const incBtn = document.getElementById("inc");
const decBtn = document.getElementById("dec");
const resetBtn = document.getElementById("reset");
// Subscribe to state changes
store.subscribe((state) => {
    countElement.textContent = state.counter.toString();
});
// Event handlers
incBtn.addEventListener("click", () => store.dispatch({ type: "INCREMENT" }));
decBtn.addEventListener("click", () => store.dispatch({ type: "DECREMENT" }));
resetBtn.addEventListener("click", () => store.dispatch({ type: "RESET" }));
// Initialize display
countElement.textContent = store.getState().counter.toString();
