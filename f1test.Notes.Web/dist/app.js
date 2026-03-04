"use strict";
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
const apiUrl = "http://127.0.0.1:39323/api/notes";
function loadNotes() {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(apiUrl);
        const notes = yield response.json();
        const list = document.getElementById("noteList");
        list.innerHTML = "";
        notes.forEach(note => {
            const li = document.createElement("li");
            li.innerText = `${note.title} - ${note.content}`;
            list.appendChild(li);
        });
    });
}
function createNote() {
    return __awaiter(this, void 0, void 0, function* () {
        const titleInput = document.getElementById("title");
        const contentInput = document.getElementById("content");
        const note = {
            title: titleInput.value,
            content: contentInput.value
        };
        yield fetch(apiUrl, {
            method: "POST",
            headers: {
                "content-type": "application/json"
            },
            body: JSON.stringify(note)
        });
        titleInput.value = "";
        contentInput.value = "";
        loadNotes();
    });
}
window.onload = loadNotes;
