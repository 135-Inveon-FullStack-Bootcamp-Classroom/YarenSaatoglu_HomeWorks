import './App.css';
import HeaderSection from './components/HeaderSection';
import KeysSection from './components/KeysSection';
import ScreenSection from './components/ScreenSection';

function App() {
  return (
    <div className="App">
      <div className="appContainer">
        <div className="calculatorContainer">
          <HeaderSection></HeaderSection>
          <ScreenSection></ScreenSection>
          <KeysSection></KeysSection>
        </div>
      </div>
    </div>
  );
}

export default App;
