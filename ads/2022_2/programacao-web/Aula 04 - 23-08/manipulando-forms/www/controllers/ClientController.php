<?php
  class ClientController {
    public function register() {
      require_once('views/templates/header.php');
      require_once('views/client/register.php');
      require_once('views/templates/footer.php');
    }

    public function registerView() {
      $arrayClient = array (
        'name' => $_POST['name'],
        'email' => $_POST['email'],
        'gender' => $_POST['gender'],
        'color' => $_POST['color'],
      );

      require_once('views/templates/header.php');
      require_once('views/client/registerView.php');
      require_once('views/templates/footer.php');
    }
  }
?>