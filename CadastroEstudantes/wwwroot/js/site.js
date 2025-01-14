
// máscara para CPF
$(document).ready(function () {
    $('#Cpf').mask('000.000.000-00');
});

// popup forms delete
function openDelete() {
    document.getElementbyId(popup).style.display = "block"
}
function closeDelete() {
    document.getElementbyId(popup).style.display = "none"
}