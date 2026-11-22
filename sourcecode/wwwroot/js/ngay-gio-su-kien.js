(function () {
    "use strict";

    function pad(value) {
        return String(value).padStart(2, "0");
    }

    function toLocalIso(date) {
        return date.getFullYear() + "-" +
            pad(date.getMonth() + 1) + "-" +
            pad(date.getDate()) + "T" +
            pad(date.getHours()) + ":" +
            pad(date.getMinutes());
    }

    function readDate(value) {
        var match = /^(\d{2})\/(\d{2})\/(\d{4})$/.exec(value.trim());

        if (!match) {
            return null;
        }

        var day = Number(match[1]);
        var month = Number(match[2]);
        var year = Number(match[3]);

        var date = new Date(year, month - 1, day);

        if (
            date.getFullYear() !== year ||
            date.getMonth() !== month - 1 ||
            date.getDate() !== day
        ) {
            return null;
        }

        return date;
    }

    function formatDisplay(date) {
        return pad(date.getDate()) + "/" +
            pad(date.getMonth() + 1) + "/" +
            date.getFullYear();
    }

    function readGroup(group) {
        var dateInput = group.querySelector("[data-date]");
        var timeInput = group.querySelector("[data-time]");

        var date = readDate(dateInput.value);
        var time = timeInput.value;

        if (!date || !/^\d{2}:\d{2}$/.test(time)) {
            return null;
        }

        var hour = Number(time.slice(0, 2));
        var minute = Number(time.slice(3, 5));

        if (hour > 23 || minute > 59) {
            return null;
        }

        date.setHours(hour, minute, 0, 0);

        return date;
    }

    document.addEventListener("DOMContentLoaded", function () {

        var groups = Array.from(
            document.querySelectorAll(".event-date-input")
        );

        if (!groups.length) {
            return;
        }

        groups.forEach(function (group) {

            var text = group.querySelector("[data-date]");
            var picker = group.querySelector("[data-picker]");
            var calendar = group.querySelector("[data-calendar]");

function updatePicker() {
    var today = new Date();

    var minDate = toLocalIso(today).slice(0, 10);

    picker.min = minDate;

    var selectedDate = readDate(text.value);

    if (selectedDate) {
        var selectedValue = toLocalIso(selectedDate).slice(0, 10);

        picker.value = selectedValue >= minDate
            ? selectedValue
            : "";
    } else {
        picker.value = "";
    }
}

            updatePicker();

            calendar.addEventListener("click", function () {

                updatePicker();

                if (typeof picker.showPicker === "function") {
                    picker.showPicker();
                } else {
                    picker.click();
                }

            });

            picker.addEventListener("change", function () {

                if (!picker.value) {
                    return;
                }

                var parts = picker.value.split("-");

                text.value =
                    parts[2] + "/" +
                    parts[1] + "/" +
                    parts[0];

                text.setCustomValidity("");

            });

            text.addEventListener("blur", function () {

                var value = readDate(text.value);

                if (value) {
                    text.value = formatDisplay(value);
                }

                var now = new Date();

                var today = new Date(
                    now.getFullYear(),
                    now.getMonth(),
                    now.getDate()
                );

                var valid = value && value >= today;

                text.setCustomValidity(
                    valid
                        ? ""
                        : "Ngày phải đúng dạng dd/MM/yyyy và không được nằm trong quá khứ."
                );

            });

text.addEventListener("input", function () {
    text.setCustomValidity("");
    updatePicker();
});

        });

        var form = groups[0].closest("form");

        if (!form) {
            return;
        }

        form.addEventListener("submit", function (event) {

            var start = readGroup(groups[0]);
            var end = readGroup(groups[1]);

            if (!start || !end) {

                event.preventDefault();

                alert(
                    "Vui lòng nhập ngày đúng định dạng dd/MM/yyyy và chọn giờ hợp lệ."
                );

                return;
            }

            if (start.getTime() < Date.now() - 60000) {

                event.preventDefault();

                alert(
                    "Thời gian bắt đầu không được nằm trong quá khứ."
                );

                return;
            }

            if (end <= start) {

                event.preventDefault();

                alert(
                    "Thời gian kết thúc phải sau thời gian bắt đầu."
                );

                return;
            }

            groups.forEach(function (group, index) {

                var hidden = document.getElementById(
                    group.dataset.target
                );

                if (hidden) {
                    hidden.value = toLocalIso(
                        index === 0 ? start : end
                    );
                }

            });

        });

    });

})();
